-- inner join
SELECT DISTINCT
    p.patient_id,
    p.first_name,
    p.last_name
FROM patients p
INNER JOIN admissions a
    ON p.patient_id = a.patient_id
WHERE a.diagnosis = 'Dementia';


-- case
SELECT 
    COUNT(CASE WHEN gender = 'M' THEN 1 END) AS male_count,
    COUNT(CASE WHEN gender = 'F' THEN 1 END) AS female_count
FROM patients;
