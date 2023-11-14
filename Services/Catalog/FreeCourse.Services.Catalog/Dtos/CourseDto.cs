﻿using FreeCourse.Services.Catalog.Models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FreeCourse.Services.Catalog.Dtos
{
    internal class CourseDto
    {

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Decimal { get; set; }

        public string UserId { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedTime { get; set; }

        public FeatureDto Feature { get; set; }
        public string CategoryId { get; set; }


        public CategoryDto Category { get; set; }
    }
}
