using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using OOP_App.NotificationContext;
using OOP_App.SharedContext;

namespace OOP_App.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}