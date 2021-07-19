using System;
using System.Collections.Generic;
using StockApplication.Models;

namespace StockApplication.Repository
{
    public interface IAlertRepository : IDisposable
    {
        IEnumerable<Alert> GetAlerts();
        void InsertAlert(Alert alert);
        void DeleteAlert(int alertId);

    }
}