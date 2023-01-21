SELECT *
  FROM (SELECT
    ROW_NUMBER() OVER(ORDER BY SCORE DESC) AS `順位`,
    name AS `名前`,
    score AS `スコア`
    FROM `results` AS `r`
    WHERE
        `r`.`score` = (
            SELECT MAX(`score`)
            FROM `results` AS `s`
            WHERE `s`.`name` = `r`.`name`))
  WHERE `順位` IN (1, 2, 3, 10);