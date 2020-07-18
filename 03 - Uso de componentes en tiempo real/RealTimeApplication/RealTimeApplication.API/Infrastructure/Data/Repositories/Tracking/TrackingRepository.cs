﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealTimeApplication.API.Infrastructure.Data.Contexts;
using RealTimeApplication.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeApplication.API.Infrastructure.Data.Repositories.Tracking
{
    using RealTimeApplication.API.Infrastructure.Data.Entities;
    public class TrackingRepository : ITrackingRepository
    {
        private readonly RealtimeapplicationContext _context;
        private readonly IMapper _mapper;

        public TrackingRepository(RealtimeapplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<TrackingDto> List()
        {
            List<TrackingDto> trackings = _mapper.Map<List<TrackingDto>>(_context.Trackings
                                                            .Include(t=>t.Order).ThenInclude(o=>o.Client)
                                                            .Include(t => t.TrackingStatus)
                                                            .Include(t => t.TrackingProducts).ThenInclude(tp=>tp.Product)
                                                            .ToList());
            trackings.ForEach(t =>
            {
                t.Total = t.TrackingProducts.Sum(tp => tp.Product.Price);
            });

            return trackings;
        }

        public TrackingDto GetByTrackingId(int trackingId)
        {
            TrackingDto tracking = _mapper.Map<TrackingDto>(_context.Trackings
                                                    .Include(t => t.Order).ThenInclude(o => o.Client)
                                                    .Include(t => t.TrackingStatus)
                                                    .Include(t => t.TrackingProducts).ThenInclude(tp => tp.Product)
                                                    .Where(w => w.TrackingId == trackingId).FirstOrDefault());

            tracking.Total = tracking.TrackingProducts.Sum(tp => tp.Product.Price);

            return tracking;
        }

        public TrackingDto Update(TrackingDto tracking)
        {
            Tracking trackingUpdate = _context.Trackings.Where(w => w.TrackingId == tracking.TrackingId).FirstOrDefault();
            trackingUpdate = _mapper.Map<Tracking>(tracking);
            _context.Trackings.Update(trackingUpdate);
            _context.SaveChanges();

            return _mapper.Map<TrackingDto>(trackingUpdate);
        }

        public TrackingDto Insert(TrackingDto tracking)
        {
            Tracking trackingCreate = new Tracking();
            trackingCreate = _mapper.Map<Tracking>(tracking);
            _context.Trackings.Add(trackingCreate);
            _context.SaveChanges();

            return _mapper.Map<TrackingDto>(trackingCreate);
        }

        public TrackingDto Delete(int trackingId)
        {
            Tracking trackingDelete = _context.Trackings.Where(w => w.TrackingId == trackingId).FirstOrDefault();
            _context.Trackings.Remove(trackingDelete);
            _context.SaveChanges();

            return _mapper.Map<TrackingDto>(trackingDelete);
        }
    }
}
