﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UBudgetApp.Model;
using Xamarin.Forms;

namespace UBudgetApp
{
  public  class ExpenseListViewModel
    {

        public ObservableCollection<Expense> Expenses { get; set; }


        //Constructor

        public ExpenseListViewModel()
        {
            Expenses = new ObservableCollection<Expense>();

             MessagingCenter.Subscribe<AddExpense, Expense>(this, "AddExpense", (page, expense) =>
             {
                 Expenses.Add(expense);

             }
             );

           

        }

    }
}
