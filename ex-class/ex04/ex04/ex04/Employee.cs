public class Employee {
    public string name;
    public double gross_salary;
    public double tax;

    public double net_salary() {
        return gross_salary - tax;
    }

    public void increase_salary(double percentage) {
        gross_salary += (gross_salary * percentage / 100);

    }
}