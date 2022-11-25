SELECT
  * ,
  CASE
    WHEN `SCORE` BETWEEN 90 AND 100 THEN '秀'
    WHEN `SCORE` BETWEEN 80 AND 89 THEN '優'
    WHEN `SCORE` BETWEEN 65 AND 79 THEN '良'
    WHEN `SCORE` BETWEEN 50 AND 64 THEN '可'
    ELSE '不可'
  END AS '評価'
 FROM `grades`;