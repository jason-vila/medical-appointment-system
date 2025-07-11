﻿using System.Collections.Generic;

namespace medical_appointment_system.Dao
{
    public interface IGenericDao<T>
    {
        int ExecuteWrite(string indicator, T entity);
        List<T> ExecuteRead(string indicator, T entity);
    }
}