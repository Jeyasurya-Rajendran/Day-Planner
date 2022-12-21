﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DisprzTraining.Models
{
    public class Appointment
    {
        [Required]
        public Guid Id{ get; init;}
        [Required]
        public DateTime? StartDateTime{ get; set;}
        [Required]
        public DateTime? EndDateTime{ get; set;}
        [Required]
        public string? Title{ get; set;}

        public Appointment(){
            this.Id = new Guid();
            this.StartDateTime = DateTime.Now;
            this.EndDateTime = DateTime.Now;
            this.Title = "";
        }
        public Appointment(Guid Id, DateTime StartDateTime, DateTime EndDateTime, string Title){
            this.Id = Id;
            this.StartDateTime = StartDateTime;
            this.EndDateTime = EndDateTime;
            this.Title = Title;
        }
    }
}
