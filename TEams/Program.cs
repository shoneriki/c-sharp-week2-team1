using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace TEams
{
    class Program
    {
        List<Department> departments = new List<Department>();
        List<Employee> employees = new List<Employee>();
        Dictionary<string, Project> projects = new Dictionary<string, Project>();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            // create some departments
            
            CreateDepartments();
            


            // print each department by name
            PrintDepartments();

            // create employees
            

            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!
            employees[1].RaiseSalary(10);

            // print all employees
            PrintEmployees();
            

            // create the TEams project
            CreateTeamsProject();
            

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private void CreateDepartments()
        {
                Department department1 = new Department(1, "Marketing");
                Department department2 = new Department(2, "Sales");
                Department department3 = new Department(3, "Engineering");
                departments.Add(department1);
                departments.Add(department2);
                departments.Add(department3);
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach (Department department in departments)
            {
                Console.WriteLine($"{department.Name}");

            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {
            Employee employee1 = new Employee(1, "Dean", "Johnson", "djohnson@teams.com", departments[2], "08/21/2020");
            Employee employee2 = new Employee(2, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020");
            Employee employee3 = new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020");
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FullName} ({employee.Salary}) {employee.Department.Name}");
            }
        }

        /**
         * Create the 'TEams' project.
         */

            Project project1 = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");
        private void CreateTeamsProject()
        {
            //{ "TEams", "Project Management Software", "10/10/2020", "11/10/2020"}

            // project1.name = "TEams"


            foreach (Employee employee in employees)
            {
                if (employee.Department.Name == "Engineering")
                {
                    project1.TeamMembers.Add(employee);
                }
            }
        }


            /**
             * Create the 'Marketing Landing Page' project.
             */

                Project landingPageProject = new Project("Marketing Landing Page", "Lead Capture Landing Page", "10/10/2020", "10/17/2020");
            private void CreateLandingPageProject()
            {

                foreach (Employee employee in employees)
                {
                    if (employee.Department.Name == "Marketing")
                    {
                        landingPageProject.TeamMembers.Add(employee);
                    }
                }
            }

                /**
                 * Print out each project in the collection.
                 */
                private void PrintProjectsReport()
                {
                    Console.WriteLine("\n------------- PROJECTS ------------------------------");
                    Console.WriteLine($"{project1.Name}: {project1.TeamMembers.Count}");
                    Console.WriteLine($"{landingPageProject.Name}: {landingPageProject.TeamMembers.Count}");
                }
            
        
    }
}

