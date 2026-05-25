INSERT INTO Continents
(ContinentName,TotalPopulation)
VALUES
('RAM',2233234234),
('RR',234234)


select * from Continents



INSERT INTO Vaccine_Types
(VaccineName,Manufacturer,
CountryOfOrigin,RequiredDoses,
EffectivenessRate,
StorageTemperature,WHOApproved)

VALUES
('Covaxin','Bharat Biotech','India',2,78.00,'2-8C',1),
('Covishield','Serum Institute','India',2,81.00,'2-8C',1),
('Pfizer','Pfizer Inc','USA',2,95.00,'-70C',1)

select * from Vaccine_Types

UPDATE Vaccine_Types
SET VaccineName = 'Nfizer'
WHERE VaccineName = 'Pfizer';

select * from Vaccine_Types



INSERT INTO Audit_Log
(TableName,OperationType,
RecordId,OldValue,
NewValue,ChangedBy)

VALUES
('Countries','INSERT',1,NULL,'India Added','Admin'),
('Countries','INSERT',2,NULL,'USA Added','Admin')

select * from Audit_Log

delete from Audit_Log
where RecordId in (1,2);

select * from Audit_Log


SELECT * 
FROM Pandemic_Cases 
ORDER BY InfectionRate DESC
OFFSET 0 ROWS 
FETCH NEXT 10 ROWS ONLY;

SELECT sum(Population) as total_population FROM Countries;

SELECT 
    (SUM(CAST(PC.TotalCases as FLOAT)) / SUM(CAST(C.Population AS FLOAT))) * 100 AS Infection_Percentage
FROM Countries C
INNER JOIN 
Pandemic_Cases PC ON C.CountryId = PC.CountryId;


select * from Pandemic_Deaths

select  TotalDeaths, DeathPercentage from Pandemic_Deaths;


select * from Pandemic_Deaths PD
INNER JOIN Countries C
ON PD.CountryId = C.CountryId;



SELECT C.CountryName , PD.TotalDeaths, PD.DeathPercentage
FROM Countries C 
INNER JOIN Pandemic_Deaths AS PD
ON PD.CountryId = C.CountryId;




select PD.CountryId, V.VaccinationPercentage  from Pandemic_Deaths PD
INNER JOIN Vaccinations V
ON PD.CountryId = V.CountryId;

SELECT * FROM Vaccinations

select SUM(CAST(TotalVaccinated AS FLOAT)) as TotalVaccinated_Population from Vaccinations


SELECT * FROM Vaccinations

select (SUM(CAST(BoosterDoseCount as FLOAT))/ SUM(CAST(TotalVaccinated as FLOAT)) * 100) as BoosterDosePercentage
FROM  Vaccinations

select DailyVaccinations from Vaccinations
order by DailyVaccinations desc




WITH DailyCases AS
(
    SELECT
        CountryId,
        ReportDate,
        NewCases
    FROM Pandemic_Cases
)

SELECT
    d1.CountryId,
    d1.ReportDate,

    AVG(CAST(d2.NewCases AS DECIMAL(10,2)))
    AS SevenDayMovingAverage

FROM DailyCases d1
JOIN DailyCases d2
ON d1.CountryId = d2.CountryId
AND d2.ReportDate BETWEEN
DATEADD(DAY,-6,d1.ReportDate)
AND d1.ReportDate

GROUP BY
d1.CountryId,
d1.ReportDate

ORDER BY
d1.CountryId,
d1.ReportDate;



select * from countries;


CREATE PROCEDURE GetCountyIdByName
@countryName varchar(100)
AS
BEGIN
select countryId from countries where @countryname=countryName;
END




exec GetCountyIdByName 'india';


CREATE PROCEDURE sp_GetCountryCovidSummary
@CountryName VARCHAR(100)
AS
BEGIN

select pc.totalcases, pd.totaldeaths, pd.deathPercentage,
v.vaccinationpercentage
FROM Pandemic_Deaths AS pd
INNER JOIN Pandemic_Cases AS pc
    ON pd.CountryId = pc.CountryId
INNER JOIN Vaccinations AS v
    ON v.CountryId = pd.CountryId
WHERE pd.CountryId = 1
AND pc.CountryId = 1
AND v.CountryId = 1;

END;




drop procedure sp_GetCountryCovidSummary

exec sp_GetCountryCovidSummary 'india';




CREATE FUNCTION fn_GetMortalityRate
(
    @CountryId INT
)
RETURNS DECIMAL(10,2)
AS
BEGIN

    DECLARE @Rate DECIMAL(10,2);

    SELECT
    @Rate =
    (CAST(TotalDeaths AS DECIMAL(10,2))
    / NULLIF(TotalCases,0))*100

    FROM Mortality_Summary
    WHERE CountryId=@CountryId;

    RETURN @Rate;

END;



SELECT dbo.fn_GetMortalityRate(1) AS MortalityRate;




CREATE TRIGGER InsertNotification on Pandemic_Deaths
AFTER INSERT
AS
BEGIN
PRINT 'Record Inserted IN pendmic_death table by aniket';
END;


drop trigger InsertNotification


INSERT INTO Pandemic_Deaths
(CountryId, ReportDate, NewDeaths, TotalDeaths,
DeathPercentage, MaleDeaths, FemaleDeaths,
ChildDeaths, SeniorCitizenDeaths)

VALUES
(1,'2026-05-01',10,530000,1.2,300000,210000,2000,18000);





CREATE VIEW Country_Wise_Vaccination_View AS
SELECT C.countryName, v.firstdosecount, v.seconddosecount, v.boosterdosecount, v.totalvaccinated
from countries c 
INNER JOIN vaccinations v 
on c.countryid= v.countryid;


select * from Country_Wise_Vaccination_View