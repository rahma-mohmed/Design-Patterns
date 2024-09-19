using System.Text;
using System.Text.Json;
using Adapter.Core;

var payrollUrl = "https://localhost:7142/api/PayrollCalculator";
var reader = new EmployeeDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();

foreach (var employee in employees)
{
    var req = new HttpRequestMessage(HttpMethod.Post, payrollUrl);
    var emp = new EmployeeAdapter(employee);
    req.Content = new StringContent(JsonSerializer.Serialize(emp), Encoding.UTF8, "application/json");

    var response = await client.SendAsync(req);
    var responeJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responeJson);

    Console.WriteLine($"Salary for employee {employee.FullName} = {salary}");
}
