SELECT
 `region` AS '地方名',
 COUNT(`name`) AS '都道府県数',
 SUM(`area`) AS '総面積'
  FROM `prefectures`
  GROUP BY `region`
  ORDER BY `総面積` DESC; 