using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using StockApplication.Models;
using System.Data.SQLite;

namespace StockApplication.Controllers
{
    public class StockController : Controller
    {
        private SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=stock-alerter.sqlite;Version=3;");

        private SQLiteCommand command;
        
        public ActionResult Stock()
        {
            var alert = new Alert();
            return View(alert);
        }
        // POST
        public ActionResult SaveStock(int id, string symbol, decimal price, string email)
        {
            Console.WriteLine("Save Stock");
            var alert = new Alert()
            {
                Id = id,
                Symbol = symbol,
                AlertPrice = price,
                Email = email,
                Sent = true
            };
            m_dbConnection.Open();
            command = new SQLiteCommand("INSERT INTO alerts VALUES (@Id, @Symbol, @AlertPrice, @Email, @Sent);", m_dbConnection);
            command.Parameters.Add(new SQLiteParameter("@Id", DbType.Int32));
            command.Parameters["@Id"].Value = id;
            command.Parameters.Add(new SQLiteParameter("@Symbol", DbType.String));
            command.Parameters["@Symbol"].Value = symbol;
            command.Parameters.Add(new SQLiteParameter("@AlertPrice", DbType.Decimal));
            command.Parameters["@AlertPrice"].Value = price;
            command.Parameters.Add(new SQLiteParameter("@Email", DbType.String));
            command.Parameters["@Email"].Value = email;
            command.Parameters.Add(new SQLiteParameter("@Sent", DbType.Binary));
            command.Parameters["@Sent"].Value = alert.Sent;
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            return  RedirectToAction("Index", "Home");
        }
        //DELETE
        public ActionResult Erase(string symbol, decimal price, string mail)
        {
            m_dbConnection.Open();
            command = new SQLiteCommand("DELETE FROM alerts WHERE alerts.Symbol=@symbol AND alerts.AlertPrice=@price AND alerts.Email=@mail", m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            return View("Stock");
        }
        //GET List
        public ActionResult StockList()
        {
            List<Alert> lAlert = new List<Alert>();
            DataTable objDataTable = new DataTable();
            m_dbConnection.Open();
            command = new SQLiteCommand("SELECT alerts.Id, alerts.Symbol, alerts.AlertPrice, alerts.Email, alerts.Sent FROM alerts;", m_dbConnection);
            command.ExecuteNonQuery();
            foreach (DataRow dataRow in objDataTable.Rows)
            {
                lAlert.Add(new Alert(){
                    Symbol = dataRow["Symbol"].ToString(),
                    AlertPrice = (decimal) dataRow["AlerPrice"],
                    Email = dataRow["Email"].ToString(),
                    Sent = (bool) dataRow["Sent"]
                });
            }
            m_dbConnection.Close();
            
            return View("Stock");
        }
    }
}