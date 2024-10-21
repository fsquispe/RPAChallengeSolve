using System;

namespace RPAChallengeSolve;

public class ChallengeModel
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string CompanyName { get; set; }
  public string RoleInCompany { get; set; }
  public string Address { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }

  public ChallengeModel() 
  {
    this.FirstName = string.Empty;
    this.LastName = string.Empty;
    this.CompanyName = string.Empty;
    this.RoleInCompany = string.Empty;
    this.Address = string.Empty;
    this.Email = string.Empty;
    this.PhoneNumber = string.Empty;
  }

  public static IList<ChallengeModel> GetDemoList()
  {
    List<ChallengeModel> lst = new();

    lst.Add(new ChallengeModel()
    {
      FirstName = "John",
      LastName = "Smith",
      CompanyName = "IT Solutions",
      RoleInCompany = "Analyst",
      Address = "98 North Road",
      Email = "jsmith@itsolutions.co.uk",
      PhoneNumber = "40716543298"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Jane",
      LastName = "Dorsey",
      CompanyName = "MediCare",
      RoleInCompany = "Medical Engineer",
      Address = "11 Crown Street",
      Email = "jdorsey@mc.com",
      PhoneNumber = "40791345621"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Albert",
      LastName = "Kipling",
      CompanyName = "Waterfront",
      RoleInCompany = "Accountant",
      Address = "22 Guild Street",
      Email = "kipling@waterfront.com",
      PhoneNumber = "40735416854"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Michael",
      LastName = "Robertson",
      CompanyName = "MediCare",
      RoleInCompany = "IT Specialist",
      Address = "17 Farburn Terrace",
      Email = "mrobertson@mc.com",
      PhoneNumber = "40733652145"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Doug",
      LastName = "Derrick",
      CompanyName = "Timepath Inc.",
      RoleInCompany = "Analyst",
      Address = "99 Shire Oak Road",
      Email = "dderrick@timepath.co.uk",
      PhoneNumber = "40799885412"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Jessie",
      LastName = "Marlowe",
      CompanyName = "Aperture Inc.",
      RoleInCompany = "Scientist",
      Address = "27 Cheshire Street",
      Email = "jmarlowe@aperture.us",
      PhoneNumber = "40733154268"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Stan",
      LastName = "Hamm",
      CompanyName = "Sugarwell",
      RoleInCompany = "Advisor",
      Address = "10 Dam Road",
      Email = "shamm@sugarwell.org",
      PhoneNumber = "40712462257"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Michelle",
      LastName = "Norton",
      CompanyName = "Aperture Inc.",
      RoleInCompany = "Scientist",
      Address = "13 White Rabbit Street",
      Email = "mnorton@aperture.us",
      PhoneNumber = "40731254562"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Stacy",
      LastName = "Shelby",
      CompanyName = "TechDev",
      RoleInCompany = "HR Manager",
      Address = "19 Pineapple Boulevard",
      Email = "sshelby@techdev.com",
      PhoneNumber = "40741785214"
    });

    lst.Add(new ChallengeModel()
    {
      FirstName = "Lara",
      LastName = "Palmer",
      CompanyName = "Timepath Inc.",
      RoleInCompany = "Programmer",
      Address = "87 Orange Street",
      Email = "lpalmer@timepath.co.uk",
      PhoneNumber = "40731653845"
    });

    return lst;
  }
}