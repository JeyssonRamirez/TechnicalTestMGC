using Core.Entities;

namespace Application.Main.Implementation
{
    public interface IFactorySalaryCalculator
    {
        ISalaryCalculator GetCalculator(ContractType contractType);
    }
}