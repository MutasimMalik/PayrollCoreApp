using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollCoreApp.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
