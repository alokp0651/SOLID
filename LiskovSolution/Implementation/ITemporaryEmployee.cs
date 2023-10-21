namespace LiskovSolution.Implementation
{
    public interface ITemporaryEmployee
    {
        decimal CalculateBonus(decimal salary);
        decimal GetMinimumSalary();
    }
}