SELECT email FROM
  (SELECT `email`, `game_id`, `score` FROM `results`
  EXCEPT SELECT `email`, `game_id`, `score`  FROM `optout`)
  GROUP BY `email` ORDER BY SUM(`score`) DESC LIMIT 10;
