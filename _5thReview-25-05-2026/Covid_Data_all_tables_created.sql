create database covid_db;

use covid_db;


create table Continents
(
ContinentId INT PRIMARY KEY IDENTITY(1,1),
ContinentName VARCHAR(100),
TotalPopulation BIGINT NOT NULL,
CreatedAt DATETIME DEFAULT GETDATE()
);

select * from Continents;

create table Countries (
CountryId INT PRIMARY KEY IDENTITY(1,1),
CountryName VARCHAR(100),
CountryCode VARCHAR(100),
ContinentId INT NOT NULL,
Population BIGINT NOT NULL,
CapitalCity VARCHAR(100),
CurrencyName VARCHAR(100),
GDP BIGINT NOT NULL,
HealthcareIndex DECIMAL(5,2),
CreatedAt DATETIME DEFAULT GETDATE()
);

select * from Countries;



CREATE TABLE Pandemic_Cases
(
 CaseId INT IDENTITY(1,1) PRIMARY KEY,
 CountryId INT NOT NULL,
 ReportDate DATE NOT NULL,
 NewCases INT DEFAULT 0,
 TotalCases INT DEFAULT 0 CHECK(TotalCases>=0),
 ActiveCases INT DEFAULT 0,
 RecoveredCases INT DEFAULT 0,
 CriticalCases INT DEFAULT 0,
 TestsConducted INT DEFAULT 0 CHECK(TestsConducted>=0),
 InfectionRate DECIMAL(6,2) CHECK(InfectionRate>=0),
 CreatedAt DATETIME DEFAULT GETDATE(),
 FOREIGN KEY(CountryId)
 REFERENCES Countries(CountryId),
 UNIQUE(CountryId,ReportDate)
);


CREATE TABLE Pandemic_Deaths(
DeathId INT PRIMARY KEY IDENTITY(1,1),
CountryId VARCHAR(100),
ReportDate DATE NOT NULL,
NewDeaths INT DEFAULT 0,
TotalDeaths INT DEFAULT 0,
DeathPercentage VARCHAR(10),
MaleDeaths INT DEFAULT 0,
FemaleDeaths INT DEFAULT 0,
ChildDeaths INT DEFAULT 0,
SeniorCitizenDeaths INT DEFAULT 0,
CreatedAt DATETIME DEFAULT GETDATE()
)

select * from Pandemic_Deaths;

create table Vaccine_Types(
VaccineTypeId INT PRIMARY KEY IDENTITY(1,1),
VaccineName VARCHAR(100),
Manufacturer VARCHAR(100),
CountryOfOrigin VARCHAR(100),
RequiredDoses VARCHAR (100),
EffectivenessRate VARCHAR (100),
StorageTemperature VARCHAR (100),
WHOApproved VARCHAR(10),
CreatedAt DATETIME DEFAULT GETDATE()
)

select * from Vaccine_Types;


create table Vaccinations(
VaccinationId INT PRIMARY KEY IDENTITY(1,1),
CountryId VARCHAR (100),
VaccineTypeId VARCHAR (100),
VaccinationDate DATE NOT NULL,
FirstDoseCount INT DEFAULT 0,
SecondDoseCount INT DEFAULT 0,
BoosterDoseCount INT DEFAULT 0,
TotalVaccinated INT DEFAULT 0,
DailyVaccinations INT DEFAULT 0,
VaccinationPercentage VARCHAR(100),
CreatedAt DATETIME DEFAULT GETDATE()
)

select * from Vaccinations;


CREATE TABLE Hospitals(
HospitalId INT PRIMARY KEY IDENTITY(1,1),
HospitalName VARCHAR(100),
CountryId VARCHAR(100),
City VARCHAR(100),
TotalBeds INT DEFAULT 0,
ICUBeds INT DEFAULT 0,
VentilatorCount INT DEFAULT 0,
DoctorsCount INT DEFAULT 0,
NursesCount INT DEFAULT 0,
CovidDedicated DATE NOT NULL,
ContactNumber BIGINT,
CreatedAt DATETIME DEFAULT GETDATE()
)

select * from Hospitals;

CREATE TABLE Government_Restrictions(
RestrictionId INT PRIMARY KEY IDENTITY(1,1),
CountryId  VARCHAR(100),
RestrictionType  VARCHAR(100),
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
RestrictionLevel  VARCHAR(100),
SchoolsClosed VARCHAR(100),
AirportsClosed  VARCHAR(100),
LockdownApplied  VARCHAR(100),
PublicGatheringRestricted  VARCHAR(100),
VaccinationMandatory VARCHAR(100),
Description  VARCHAR(200),
CreatedAt DATETIME DEFAULT GETDATE()
)


select * from Government_Restrictions;

CREATE TABLE Mortality_Summary (
SummaryId INT PRIMARY KEY IDENTITY(1,1),
CountryId VARCHAR(100),
TotalCases INT DEFAULT 0,
TotalDeaths INT DEFAULT 0,
MortalityRate VARCHAR(100),
LastUpdated DATE NOT NULL
)



CREATE TABLE Audit_Log (
AuditId  INT PRIMARY KEY IDENTITY(1,1),
TableName VARCHAR (100),
OperationType VARCHAR(100),
RecordId INT NOT NULL,
OldValue INT DEFAULT 0,
NewValue INT DEFAULT 0,
ChangedBy VARCHAR(100),
CreatedAt DATETIME DEFAULT GETDATE()
);



USE covid_db;
GO

DROP TABLE IF EXISTS Audit_Log;
DROP TABLE IF EXISTS Mortality_Summary;
DROP TABLE IF EXISTS Government_Restrictions;
DROP TABLE IF EXISTS Hospitals;
DROP TABLE IF EXISTS Vaccinations;
DROP TABLE IF EXISTS Vaccine_Types;
DROP TABLE IF EXISTS Pandemic_Deaths;
DROP TABLE IF EXISTS Pandemic_Cases;
DROP TABLE IF EXISTS Countries;
DROP TABLE IF EXISTS Continents;

GO



CREATE DATABASE covid_db;
USE covid_db;














------------------------------------------
-- Continents
------------------------------------------

CREATE TABLE Continents
(
    ContinentId INT PRIMARY KEY IDENTITY(1,1),
    ContinentName VARCHAR(100) UNIQUE,
    TotalPopulation BIGINT NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);


------------------------------------------
-- Countries
------------------------------------------

CREATE TABLE Countries
(
    CountryId INT PRIMARY KEY IDENTITY(1,1),
    CountryName VARCHAR(100) UNIQUE,
    CountryCode VARCHAR(10),
    ContinentId INT NOT NULL,
    Population BIGINT NOT NULL,
    CapitalCity VARCHAR(100),
    CurrencyName VARCHAR(100),
    GDP BIGINT NOT NULL,
    HealthcareIndex DECIMAL(5,2),
    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ContinentId)
    REFERENCES Continents(ContinentId)
);


------------------------------------------
-- Pandemic Cases
------------------------------------------

CREATE TABLE Pandemic_Cases
(
    CaseId INT PRIMARY KEY IDENTITY(1,1),
    CountryId INT NOT NULL,
    ReportDate DATE NOT NULL,

    NewCases INT DEFAULT 0 CHECK(NewCases>=0),
    TotalCases INT DEFAULT 0 CHECK(TotalCases>=0),
    ActiveCases INT DEFAULT 0 CHECK(ActiveCases>=0),
    RecoveredCases INT DEFAULT 0 CHECK(RecoveredCases>=0),
    CriticalCases INT DEFAULT 0 CHECK(CriticalCases>=0),

    TestsConducted INT DEFAULT 0 CHECK(TestsConducted>=0),

    InfectionRate DECIMAL(6,2)
    CHECK(InfectionRate>=0),

    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId),

    UNIQUE(CountryId,ReportDate)
);


------------------------------------------
-- Pandemic Deaths
------------------------------------------

CREATE TABLE Pandemic_Deaths
(
    DeathId INT PRIMARY KEY IDENTITY(1,1),

    CountryId INT NOT NULL,

    ReportDate DATE NOT NULL,

    NewDeaths INT DEFAULT 0 CHECK(NewDeaths>=0),

    TotalDeaths INT DEFAULT 0 CHECK(TotalDeaths>=0),

    DeathPercentage DECIMAL(5,2),

    MaleDeaths INT DEFAULT 0,
    FemaleDeaths INT DEFAULT 0,
    ChildDeaths INT DEFAULT 0,
    SeniorCitizenDeaths INT DEFAULT 0,

    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId)
);


------------------------------------------
-- Vaccine Types
------------------------------------------

CREATE TABLE Vaccine_Types
(
    VaccineTypeId INT PRIMARY KEY IDENTITY(1,1),

    VaccineName VARCHAR(100),

    Manufacturer VARCHAR(100),

    CountryOfOrigin VARCHAR(100),

    RequiredDoses INT,

    EffectivenessRate DECIMAL(5,2),

    StorageTemperature VARCHAR(100),

    WHOApproved BIT DEFAULT 0,

    CreatedAt DATETIME DEFAULT GETDATE()
);


------------------------------------------
-- Vaccinations
------------------------------------------

CREATE TABLE Vaccinations
(
    VaccinationId INT PRIMARY KEY IDENTITY(1,1),

    CountryId INT NOT NULL,

    VaccineTypeId INT NOT NULL,

    VaccinationDate DATE NOT NULL,

    FirstDoseCount INT DEFAULT 0,

    SecondDoseCount INT DEFAULT 0,

    BoosterDoseCount INT DEFAULT 0,

    TotalVaccinated INT DEFAULT 0,

    DailyVaccinations INT DEFAULT 0,

    VaccinationPercentage DECIMAL(5,2),

    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId),

    FOREIGN KEY(VaccineTypeId)
    REFERENCES Vaccine_Types(VaccineTypeId)
);


------------------------------------------
-- Hospitals
------------------------------------------

CREATE TABLE Hospitals
(
    HospitalId INT PRIMARY KEY IDENTITY(1,1),

    HospitalName VARCHAR(100),

    CountryId INT NOT NULL,

    City VARCHAR(100),

    TotalBeds INT DEFAULT 0,

    ICUBeds INT DEFAULT 0,

    VentilatorCount INT DEFAULT 0,

    DoctorsCount INT DEFAULT 0,

    NursesCount INT DEFAULT 0,

    CovidDedicated BIT DEFAULT 0,

    ContactNumber VARCHAR(15),

    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId)
);


------------------------------------------
-- Government Restrictions
------------------------------------------

CREATE TABLE Government_Restrictions
(
    RestrictionId INT PRIMARY KEY IDENTITY(1,1),

    CountryId INT NOT NULL,

    RestrictionType VARCHAR(100),

    StartDate DATE NOT NULL,

    EndDate DATE NOT NULL,

    RestrictionLevel VARCHAR(100),

    SchoolsClosed BIT DEFAULT 0,

    AirportsClosed BIT DEFAULT 0,

    LockdownApplied BIT DEFAULT 0,

    PublicGatheringRestricted BIT DEFAULT 0,

    VaccinationMandatory BIT DEFAULT 0,

    Description VARCHAR(200),

    CreatedAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId)
);


------------------------------------------
-- Mortality Summary
------------------------------------------

CREATE TABLE Mortality_Summary
(
    SummaryId INT PRIMARY KEY IDENTITY(1,1),

    CountryId INT NOT NULL,

    TotalCases INT DEFAULT 0,

    TotalDeaths INT DEFAULT 0,
   
    MortalityRate DECIMAL(5,2),

    LastUpdated DATE NOT NULL,

    FOREIGN KEY(CountryId)
    REFERENCES Countries(CountryId)
);

--
------------------------------------------
-- Audit Log
------------------------------------------

CREATE TABLE Audit_Log
(
    AuditId INT PRIMARY KEY IDENTITY(1,1),

    TableName VARCHAR(100),

    OperationType VARCHAR(20),

    RecordId INT NOT NULL,

    OldValue VARCHAR(MAX),

    NewValue VARCHAR(MAX),

    ChangedBy VARCHAR(100),

    CreatedAt DATETIME DEFAULT GETDATE()
);