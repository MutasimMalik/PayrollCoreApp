using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCoreApp.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
