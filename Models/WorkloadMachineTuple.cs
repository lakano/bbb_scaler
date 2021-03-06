﻿using HPI.BBB.Autoscaler.Models;
using HPI.BBB.Autoscaler.Models.Ionos;
using System;
using System.Collections.Generic;

namespace HPI.BBB.Autoscaler.Models
{
    internal class WorkloadMachineTuple
    {
        public string DataCenter { get; }
        public IonosMachine Machine { get; }
        public Workload Workload { get; }

        public WorkloadMachineTuple(string dc, IonosMachine m, Workload w)
        {
            DataCenter = dc;
            Machine = m;
            Workload = w;
        }

        public override bool Equals(object obj)
        {
            return obj is WorkloadMachineTuple other &&
                   EqualityComparer<IonosMachine>.Default.Equals(Machine, other.Machine) &&
                   EqualityComparer<Workload>.Default.Equals(Workload, other.Workload) &&
                   EqualityComparer<string>.Default.Equals(DataCenter, other.DataCenter);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DataCenter, Machine, Workload);
        }
    }
}
