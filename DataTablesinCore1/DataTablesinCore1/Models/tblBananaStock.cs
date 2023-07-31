using System.ComponentModel.DataAnnotations;

namespace DataTablesinCore1.Models
{
        public class tblBananaStock
        {
            [Key]
            public int Id { get; set; }
            public string Transaction_ref { get; set; } = string.Empty;
            public string Transaction_Typ { get; set; } = string.Empty;
            public string Person_Name { get; set; } = string.Empty;
            public string PersonPhone { get; set; } = string.Empty;
            public string PersonType { get; set; } = string.Empty;
            public int PurCarate { get; set; } = 0;
            public int SalCarate { get; set; } = 0;
            public int CompanyPrevcarat { get; set; } = 0;
            public int SubTotalCarate { get; set; } = 0;
            public int MTCarate { get; set; } = 0;
            public int CompanyRemainCarate { get; set; } = 0;
            public int PersonPrevCaratBal { get; set; } = 0;
            public int PersonRemainCarate { get; set; } = 0;
            public int Weight { get; set; } = 0;
            public decimal Rate { get; set; } = 0;
            public decimal GrossAmt { get; set; } = 0;
            public decimal PersonPrevBal { get; set; } = 0;
            public decimal PersonTotalBal { get; set; } = 0;
            public decimal Transport { get; set; } = 0;
            public decimal Labor { get; set; } = 0;
            public decimal GrandTotalAmt { get; set; } = 0;
            public decimal Deposit_Payment { get; set; } = 0;
            public decimal ComputeRate { get; set; } = 0;
            public decimal PersonRemainBal { get; set; } = 0;
            public string? Details { get; set; } = string.Empty;

            [DataType(DataType.Date, ErrorMessage = "Date only")]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Transaction_Dt { get; set; }

            [DataType(DataType.Date, ErrorMessage = "Date only")]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime EntryDate { get; set; } = DateTime.Now;
            public string Room { get; set; } = string.Empty;
            public decimal Discount { get; set; }
            public int SalCarateB { get; set; }
            public decimal RateB { get; set; }
            public int SoldCarates { get; set; } = 0;
        }
    }
