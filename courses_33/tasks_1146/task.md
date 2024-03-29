アルルたちの成績を後輩が入手しました。この後輩はどの科目が「楽単」なのかを調べようとしています。

---

ある学校の期末成績情報が格納されている、 grades テーブルのみをもつデータベースが与えられます。

この学校では各々の成績に対して、点数に応じて次のような 5 段階の「評価」が付けられます。

| 点数 | 90 ～ 100 | 80 ～ 89 | 65 ～ 79 | 50 ～ 64 | 0 ～ 49 |
| ---- | --------- | -------- | -------- | -------- | ------- |
| 評価 | 秀        | 優       | 良       | 可       | 不可    |

科目ごとにそれぞれの評価を何人が取得したかを分析して表示するクエリを作成してください。

ただし、科目名を格納するカラムのカラム名は「科目」、 それぞれの評価を取得した人数を格納するカラムのカラム名はそれぞれ「秀」「優」「良」「可」「不可」としてください。

---

### ヒント 1. 条件付き COUNT

SQL 文の `COUNT` 関数は、その引数（カッコの中の値）が `NULL` でないときにカウントします。 そのため、`COUNT` 文の中に条件式を単に書くだけでは、その返り値が `0` か `1` になるので、いずれにせよカウントされてしまいます。

条件を満たす時だけカウントさせるためには、条件を満たさないときに `NULL` となるような式をかけばよいです。 具体的には、以下のように `[条件] OR NULL` とするとよいです。以下の例では、aaa カラムが 3 未満のエントリの数をカウントすることができます。
`SELECT COUNT(aaa < 3 OR NULL) from xxxxx;`

## テーブル定義

| 物理名  | 型   | 必須? | 初期値 | 主キー? | 備考                  |
| ------- | ---- | ----- | ------ | ------- | --------------------- |
| id      | INT  | YES   | NULL   | YES     | id、一意制約          |
|         |      |       |        |         |                       |
| name    | TEXT | YES   | NULL   | NO      | 名前                  |
| subject | TEXT | YES   | NULL   | NO      | 科目                  |
| score   | INT  | YES   | NULL   | NO      | 点数、0 以上 100 以下 |

## データ例

| id  | name   | subject    | score |
| --- | ------ | ---------- | ----- |
| 1   | アララ | 法         | 69    |
| 2   | アララ | 第二外国語 | 69    |
| 3   | アララ | 経済       | 83    |
| 4   | アララ | 英語       | 48    |
| 5   | アリリ | 哲学       | 75    |
| 6   | アリリ | 政治       | 68    |
| 7   | アリリ | 法         | 67    |
| 8   | アリリ | 第二外国語 | 77    |
| 9   | アリリ | 経済       | 73    |
| 10  | アリリ | 英語       | 90    |
| 11  | アルル | 哲学       | 75    |
| 12  | アルル | 法         | 73    |
| 13  | アルル | 第二外国語 | 82    |
| 14  | アルル | 経済       | 55    |
| 15  | アルル | 英語       | 92    |
| 16  | アレレ | 政治       | 80    |
| 17  | アレレ | 第二外国語 | 72    |
| 18  | アレレ | 経済       | 48    |
| 19  | アレレ | 英語       | 79    |
| 20  | アロロ | 第二外国語 | 85    |
| 21  | アロロ | 経済       | 75    |
| 22  | アロロ | 英語       | 54    |
| 23  | イララ | 哲学       | 57    |
| 24  | イララ | 政治       | 30    |
| 25  | イララ | 法         | 47    |
| 26  | イララ | 第二外国語 | 81    |
| 27  | イララ | 経済       | 62    |
| 28  | イララ | 英語       | 86    |
| 29  | イリリ | 哲学       | 70    |
| 30  | イリリ | 政治       | 85    |
| 31  | イリリ | 法         | 52    |
| 32  | イルル | 哲学       | 82    |
| 33  | イルル | 政治       | 82    |
| 34  | イルル | 法         | 85    |
| 35  | イルル | 第二外国語 | 73    |
| 36  | イルル | 経済       | 77    |
| 37  | イレレ | 哲学       | 67    |
| 38  | イレレ | 政治       | 64    |
| 39  | イレレ | 第二外国語 | 61    |
| 40  | イレレ | 経済       | 79    |
| 41  | イロロ | 哲学       | 80    |
| 42  | イロロ | 政治       | 84    |
| 43  | イロロ | 法         | 54    |
| 44  | イロロ | 第二外国語 | 58    |
| 45  | イロロ | 経済       | 94    |
| 46  | イロロ | 英語       | 85    |
| 47  | ウララ | 政治       | 49    |
| 48  | ウララ | 法         | 70    |
| 49  | ウララ | 第二外国語 | 94    |
| 50  | ウララ | 経済       | 63    |
