use covid_db;

INSERT INTO Continents
(ContinentName,TotalPopulation)
VALUES
('Asia',4700000000),
('Europe',750000000),
('Africa',1400000000),
('North America',600000000),
('South America',430000000),
('Australia',45000000),
('Antarctica',1000),
('Middle East',300000000),
('Central America',180000000),
('Oceania',43000000);


select * from Continents


INSERT INTO Countries
(CountryName,CountryCode,ContinentId,
Population,CapitalCity,
CurrencyName,GDP,HealthcareIndex)

VALUES
('India','IND',1,1400000000,'New Delhi','INR',3500000,72.50),
('USA','USA',4,335000000,'Washington','USD',25000000,82.10),
('China','CHN',1,1420000000,'Beijing','Yuan',18000000,74.00),
('Germany','GER',2,84000000,'Berlin','Euro',4500000,89.30),
('Brazil','BRA',5,214000000,'Brasilia','Real',2200000,68.20),
('Canada','CAN',4,39000000,'Ottawa','CAD',2100000,90.00),
('Australia','AUS',6,26000000,'Canberra','AUD',1700000,91.40),
('Japan','JPN',1,125000000,'Tokyo','Yen',4200000,92.60),
('South Africa','RSA',3,60000000,'Pretoria','Rand',450000,65.40),
('UK','GBR',2,68000000,'London','Pound',3100000,88.20);

select * from Countries



INSERT INTO Vaccine_Types
(VaccineName,Manufacturer,
CountryOfOrigin,RequiredDoses,
EffectivenessRate,
StorageTemperature,WHOApproved)

VALUES
('Covaxin','Bharat Biotech','India',2,78.00,'2-8C',1),
('Covishield','Serum Institute','India',2,81.00,'2-8C',1),
('Pfizer','Pfizer Inc','USA',2,95.00,'-70C',1),
('Moderna','Moderna Inc','USA',2,94.10,'-20C',1),
('Sputnik V','Gamaleya','Russia',2,91.00,'-18C',1),
('Sinovac','Sinovac','China',2,79.00,'2-8C',1),
('Sinopharm','Sinopharm','China',2,80.00,'2-8C',1),
('Johnson','J&J','USA',1,72.00,'2-8C',1),
('Novavax','Novavax','USA',2,89.00,'2-8C',1),
('AstraZeneca','Oxford','UK',2,82.00,'2-8C',1);


select * from Vaccine_Types



INSERT INTO Pandemic_Cases
(CountryId,ReportDate,
NewCases,TotalCases,
ActiveCases,RecoveredCases,
CriticalCases,TestsConducted,
InfectionRate)

VALUES
(1,'2026-05-01',1200,45000000,4000,44900000,300,2000000,3.2),
(2,'2026-05-01',800,35000000,2000,34950000,150,1500000,2.5),
(3,'2026-05-01',700,50000000,5000,49900000,400,3000000,3.7),
(4,'2026-05-01',250,12000000,700,11900000,60,600000,1.8),
(5,'2026-05-01',500,22000000,1800,21900000,100,800000,2.2),
(6,'2026-05-01',100,4000000,300,3950000,20,200000,1.2),
(7,'2026-05-01',50,2000000,100,1980000,5,100000,0.7),
(8,'2026-05-01',300,18000000,900,17900000,50,700000,1.9),
(9,'2026-05-01',200,4500000,500,4400000,25,300000,1.5),
(10,'2026-05-01',400,14000000,1000,13900000,75,650000,2.0);


INSERT INTO Pandemic_Deaths
(CountryId,ReportDate,
NewDeaths,TotalDeaths,
DeathPercentage,
MaleDeaths,FemaleDeaths,
ChildDeaths,
SeniorCitizenDeaths)

VALUES
(1,'2026-05-01',10,530000,1.2,300000,210000,2000,18000),
(2,'2026-05-01',7,400000,1.1,230000,160000,1000,9000),
(3,'2026-05-01',5,200000,0.5,100000,95000,1000,4000),
(4,'2026-05-01',3,100000,0.8,52000,45000,300,2000),
(5,'2026-05-01',4,150000,0.9,80000,68000,500,3000),
(6,'2026-05-01',1,50000,0.6,26000,22000,150,1000),
(7,'2026-05-01',1,20000,0.4,11000,8000,50,500),
(8,'2026-05-01',2,80000,0.7,42000,35000,200,1500),
(9,'2026-05-01',2,70000,1.1,38000,30000,250,2500),
(10,'2026-05-01',4,90000,0.8,47000,39000,400,2000);




INSERT INTO Vaccinations
(CountryId,VaccineTypeId,
VaccinationDate,
FirstDoseCount,
SecondDoseCount,
BoosterDoseCount,
TotalVaccinated,
DailyVaccinations,
VaccinationPercentage)

VALUES
(1,1,'2026-05-01',900000000,850000000,500000000,1200000000,10000,85),
(2,3,'2026-05-01',200000000,180000000,100000000,250000000,5000,78),
(3,6,'2026-05-01',1000000000,950000000,700000000,1300000000,6000,88),
(4,3,'2026-05-01',70000000,65000000,40000000,75000000,1000,90),
(5,2,'2026-05-01',120000000,110000000,50000000,150000000,2000,70),
(6,4,'2026-05-01',30000000,28000000,10000000,32000000,500,80),
(7,3,'2026-05-01',20000000,18000000,5000000,22000000,300,83),
(8,5,'2026-05-01',100000000,95000000,40000000,110000000,800,87),
(9,2,'2026-05-01',30000000,25000000,10000000,35000000,200,58),
(10,10,'2026-05-01',50000000,45000000,15000000,55000000,700,80);


INSERT INTO Hospitals
(HospitalName,CountryId,City,
TotalBeds,ICUBeds,
VentilatorCount,
DoctorsCount,
NursesCount,
CovidDedicated,
ContactNumber)

VALUES
('AIIMS Delhi',1,'Delhi',3000,500,200,1000,1500,1,'9991111111'),
('Mayo Clinic',2,'Minnesota',2500,400,150,800,1200,1,'9992222222'),
('Beijing Medical',3,'Beijing',2800,350,180,900,1300,1,'9993333333'),
('Berlin Hospital',4,'Berlin',1800,250,100,500,700,1,'9994444444'),
('Sao Hospital',5,'Sao Paulo',2000,300,120,600,900,1,'9995555555'),
('Toronto Health',6,'Toronto',1500,200,80,450,650,0,'9996666666'),
('Sydney Medical',7,'Sydney',1300,180,70,400,550,0,'9997777777'),
('Tokyo Care',8,'Tokyo',2200,320,150,700,1000,1,'9998888888'),
('Cape Hospital',9,'Cape Town',1200,160,60,350,500,0,'9999999999'),
('London Medical',10,'London',2400,350,170,850,1200,1,'8888888888');






INSERT INTO Government_Restrictions
(CountryId,RestrictionType,
StartDate,EndDate,
RestrictionLevel,
SchoolsClosed,
AirportsClosed,
LockdownApplied,
PublicGatheringRestricted,
VaccinationMandatory,
Description)

VALUES
(1,'Lockdown','2026-01-01','2026-02-01','High',1,1,1,1,1,'Nationwide restrictions'),
(2,'Travel Ban','2026-01-05','2026-02-10','Medium',0,1,0,1,1,'Travel restrictions'),
(3,'Mask Rule','2026-01-10','2026-03-01','Low',0,0,0,1,0,'Masks mandatory'),
(4,'Partial Lockdown','2026-01-01','2026-01-25','Medium',1,0,1,1,0,'Partial restrictions'),
(5,'Health Alert','2026-02-01','2026-03-01','Low',0,0,0,1,0,'Public alerts'),
(6,'Travel Ban','2026-02-05','2026-03-10','Medium',0,1,0,1,0,'Travel control'),
(7,'Isolation Rule','2026-01-15','2026-02-15','Low',0,0,0,0,0,'Isolation for patients'),
(8,'Lockdown','2026-01-01','2026-01-30','High',1,1,1,1,1,'Full lockdown'),
(9,'Mask Rule','2026-02-01','2026-03-05','Low',0,0,0,1,0,'Masks in public'),
(10,'Travel Ban','2026-02-01','2026-03-01','Medium',0,1,0,1,1,'Airport checks');




INSERT INTO Mortality_Summary
(CountryId,TotalCases,TotalDeaths,
MortalityRate,LastUpdated)

VALUES
(1,45000000,530000,1.2,'2026-05-01'),
(2,35000000,400000,1.1,'2026-05-01'),
(3,50000000,200000,0.5,'2026-05-01'),
(4,12000000,100000,0.8,'2026-05-01'),
(5,22000000,150000,0.9,'2026-05-01'),
(6,4000000,50000,0.6,'2026-05-01'),
(7,2000000,20000,0.4,'2026-05-01'),
(8,18000000,80000,0.7,'2026-05-01'),
(9,4500000,70000,1.1,'2026-05-01'),
(10,14000000,90000,0.8,'2026-05-01');






INSERT INTO Audit_Log
(TableName,OperationType,
RecordId,OldValue,
NewValue,ChangedBy)

VALUES
('Countries','INSERT',1,NULL,'India Added','Admin'),
('Countries','INSERT',2,NULL,'USA Added','Admin'),
('Countries','INSERT',3,NULL,'China Added','Admin'),
('Vaccinations','UPDATE',1,'80','85','System'),
('Pandemic_Cases','UPDATE',2,'700','800','Admin'),
('Hospitals','INSERT',4,NULL,'Berlin Hospital','Admin'),
('Restrictions','INSERT',5,NULL,'Health Alert','Admin'),
('Mortality','UPDATE',6,'0.5','0.6','System'),
('Vaccinations','UPDATE',8,'84','87','Admin'),
('Cases','UPDATE',10,'300','400','System');




select * from Continents;

select * from Countries;

select * from Vaccine_Types

select * from Pandemic_Cases

select * from Pandemic_Deaths

select * from Vaccinations

select * from Hospitals

select * from Government_Restrictions

select * from Mortality_Summary

select * from Audit_Log