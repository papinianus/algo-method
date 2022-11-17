SELECT * FROM `users`
  WHERE `name` LIKE '%RURU'
    AND `flg_data_public` <> 0
    AND  `rank` IS NULL;