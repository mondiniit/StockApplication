using System;
using System.Collections.Generic;
using StockApplication.Models;

namespace StockApplication.Repository
{
    public class AlertRepository : IAlertRepository, IDisposable
    {

        private ApplicationContext context;
        
        public AlertRepository(AlertContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alert> GetAlerts()
        {
            return context.Alert.ToList();
        }

        public void InsertAlert(Alert alert)
        {
            context.Alert.Add(alert);
        }

        public void DeleteAlert(int alertId)
        {
            throw new NotImplementedException();
        }
    }
}