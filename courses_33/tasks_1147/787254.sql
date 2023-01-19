SELECT
  ROW_NUMBER() OVER(ORDER BY `score` DESC) AS `順位`,
  `name` AS `名前`,
  `score` AS `スコア`
  FROM `results`
  WHERE
    `name` NOT IN (SELECT `name` FROM `optout`)
  ORDER BY `score` DESC;