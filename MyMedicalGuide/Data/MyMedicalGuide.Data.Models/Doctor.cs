﻿using MyMedicalGuide.Data.Common.Models;
using System.Collections.Generic;

namespace MyMedicalGuide.Data.Models
{
    public class Doctor : BaseModel<int>
    {
        private ICollection<Patient> patients;

        private ICollection<Appointment> appointments;

        private ICollection<CustomAppointment> customAppointments;

        public Doctor()
        {
            this.patients = new HashSet<Patient>();
            this.appointments = new HashSet<Appointment>();
            this.customAppointments = new HashSet<CustomAppointment>();
        }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients
        {
            get
            {
                return this.patients;
            }
            set
            {
                this.patients = value;
            }
        }
        public virtual ICollection<Appointment> Appointments
        {
            get
            {
                return this.appointments;
            }
            set
            {
                this.appointments = value;
            }
        }

        public virtual ICollection<CustomAppointment> CustomAppointments
        {
            get
            {
                return this.customAppointments;
            }
            set
            {
                this.customAppointments = value;
            }
        }
    }
}