﻿using MLTO.Contracts;
using MLTO.Data;
using MLTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLTO.Services
{
    public class AlgorithmService : IAlgorithm
    {
        private readonly Guid _userId;
        
         public AlgorithmService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateAlgorithm(AlgorithmCreate model)
        {
            var entity =
                new Algorithm()
                {
                    OwnerId = _userId,
                    LearningAlgorithm = model.LearningAlgorithm,
                    MasteryLevel = model.MasteryLevel,
                    CreatedUtc = DateTimeOffset.Now
                };
            
             using (var ctx = new ApplicationDbContext())
            {
                ctx.Algorithms.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AlgorithmListItem> GetAlgorithms()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Algorithms
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new AlgorithmListItem
                                {
                                    AlgorithmId = e.AlgorithmId,
                                    LearningAlgorithm = e.LearningAlgorithm,
                                    MasteryLevel = e.MasteryLevel,
                                    CreatedUtc = e.CreatedUtc,
                                    ModifiedUtc = e.ModifiedUtc,
                                    LearningStyle = e.LearningStyle,
                                    LearningType = e.LearningType
                                }
                        );
                
                 return query.ToArray();
            }
        }

        public AlgorithmDetail GetAlgorithmById(int AlgorithmId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Algorithms
                        .Single(e => e.AlgorithmId == AlgorithmId && e.OwnerId == _userId);
                return
                    new AlgorithmDetail
                    {
                        AlgorithmId = entity.AlgorithmId,
                        LearningAlgorithm = entity.LearningAlgorithm,
                        MasteryLevel = entity.MasteryLevel,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateAlgorithm(AlgorithmEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Algorithms
                        .Single(e => e.AlgorithmId == model.AlgorithmId && e.OwnerId == _userId);
                
                entity.LearningAlgorithm = model.LearningAlgorithm;
                entity.MasteryLevel = model.MasteryLevel;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;
                
         return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteAlgorithm(int AlgorithmId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Algorithms
                        .Single(e => e.AlgorithmId == AlgorithmId && e.OwnerId == _userId);

                ctx.Algorithms.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
