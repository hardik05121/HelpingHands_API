﻿

using HelpingHands_API.Data;
using HelpingHands_API.Models;
using HelpingHands_API.Repository;
using HelpingHands_API.Repository.IRepostiory;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelpingHands_API.Repository
{
    public class ReviewXCommentRepository : Repository<ReviewXComment>, IReviewXCommentRepository
    {
        private readonly ApplicationDbContext _db;
        public ReviewXCommentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

  
        public async Task<ReviewXComment> UpdateAsync(ReviewXComment entity)
        {

             
            _db.ReviewXComments.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
