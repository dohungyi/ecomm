﻿using System;

namespace Ecommerce.Application.Ratings.Dto
{
    public class RatingDto
    {
        public string Comment { get; init; }
        public int Rate { get; init; }
        public string ImageUrl { get; init; }
        public DateTime CreateAt { get; init; }
        public string UserName { get; init; }
    }
}
