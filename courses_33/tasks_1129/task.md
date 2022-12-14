## 問題文

日本全国にはアメダスが約 1300 箇所設置されており、降水量等のみを計測するものを除いた 900 箇所ほどでは、常に気温が観測されています。

この観測地点ごと、8 月の平均最高気温と平均最低気温が格納されている `temperature_august` テーブルのみをもつデータベースが与えられます。

これに格納されている最高気温のうち最大のものと、最低気温のうち最小のものを取得し、 前者を `最高気温`、後者を `最低気温` というカラム名で一行に表示するクエリを作成してください。

### ヒント 1. 集約関数

複数のデータから一つの結果を計算するには 集約関数 と呼ばれる関数を使います。 たとえば、テーブル名が `xxxxx` のテーブルにおいて、`yyyyy` カラムの値が最も大きいものを表示するには、次のようなクエリを書けばよいです。
`SELECT MAX(yyyyy) FROM xxxxx;`

### ヒント 2. カラム名の変更

テーブル名が `xxxxx` のテーブルについて、`col_1` というカラムの情報を `カラム名` というカラム名で全て表示するには、次のようなクエリを書けばよいです。
`SELECT col_1 AS 'カラム名' FROM xxxxx;`

## テーブル定義

| 物理名     | 型    | 必須? | 初期値 | 主キー? | 備考                     |
| ---------- | ----- | ----- | ------ | ------- | ------------------------ |
| station_id | INT   | YES   | NULL   | YES     | 観測所 ID, 一意制約      |
| name       | TEXT  | NO    | NULL   | NO      | 観測所名                 |
| prefecture | TEXT  | NO    | NULL   | NO      | 都道府県                 |
| highest    | float | NO    | NULL   | NO      | 8 月の最高気温平年値 [℃] |
| lowest     | float | NO    | NULL   | NO      | 8 月の最低気温平年値 [℃] |

## データ例

| station_id | name     | prefecture | highest | lowest |
| ---------- | -------- | ---------- | ------- | ------ |
| 11001      | 宗谷岬   | 北海道     | 21.6    | 16.2   |
| 11016      | 稚内     | 北海道     | 22.3    | 17.2   |
| 11046      | 礼文     | 北海道     | 22.6    | 17.3   |
| 11061      | 声問     | 北海道     | 23.3    | 15.1   |
| 11076      | 浜鬼志別 | 北海道     | 21.7    | 15.2   |
| 11091      | 本泊     | 北海道     | 23.1    | 16.5   |
| 11121      | 沼川     | 北海道     | 23.1    | 14.4   |
| 11151      | 沓形     | 北海道     | 23.1    | 16.6   |
| 11176      | 豊富     | 北海道     | 23.6    | 15.6   |
| 11206      | 浜頓別   | 北海道     | 22.8    | 15.7   |
| 11276      | 中頓別   | 北海道     | 24.4    | 14.5   |
| 11291      | 北見枝幸 | 北海道     | 22.4    | 16.3   |
| 11316      | 歌登     | 北海道     | 24.1    | 14.5   |
| 12011      | 中川     | 北海道     | 24.7    | 14.7   |
| 12041      | 音威子府 | 北海道     | 24.8    | 15.2   |
| 12141      | 美深     | 北海道     | 25.8    | 15.5   |
| 12181      | 名寄     | 北海道     | 25.7    | 15.1   |
| 12231      | 下川     | 北海道     | 25      | 14.7   |
| 12261      | 士別     | 北海道     | 25.6    | 15.7   |
| 12266      | 朝日     | 北海道     | 25.6    | 15.4   |
| 12301      | 和寒     | 北海道     | 26      | 15.9   |
| 12386      | 江丹別   | 北海道     | 25.8    | 15.1   |
| 12396      | 比布     | 北海道     | 26.3    | 16     |
| 12411      | 上川     | 北海道     | 24.7    | 14.5   |
| 12442      | 旭川     | 北海道     | 26.6    | 16.9   |
| 12451      | 東川     | 北海道     | 26      | 16.1   |
| 12501      | 東神楽   | 北海道     | 26      | 16     |
| 12512      | 志比内   | 北海道     | 25.2    | 15.4   |
| 12551      | 美瑛     | 北海道     | 25.8    | 15.2   |
| 12596      | 上富良野 | 北海道     | 26.4    | 16.4   |
| 12626      | 富良野   | 北海道     | 26.3    | 16.3   |
| 12632      | 麓郷     | 北海道     | 25.3    | 15.2   |
| 12691      | 幾寅     | 北海道     | 24.3    | 14.9   |
| 12746      | 占冠     | 北海道     | 24.7    | 15     |
| 13061      | 天塩     | 北海道     | 23.6    | 15.2   |
| 13086      | 遠別     | 北海道     | 24.6    | 15.9   |
| 13121      | 初山別   | 北海道     | 24.2    | 16.3   |
| 13146      | 焼尻     | 北海道     | 23.4    | 18.5   |
| 13181      | 羽幌     | 北海道     | 24.7    | 17.3   |
| 13261      | 達布     | 北海道     | 26      | 16     |
| 13277      | 留萌     | 北海道     | 24.6    | 17.7   |
| 13311      | 増毛     | 北海道     | 24.7    | 17.3   |
| 13321      | 幌糠     | 北海道     | 25.7    | 15.8   |
| 14026      | 浜益     | 北海道     | 25.4    | 17.5   |
| 14071      | 厚田     | 北海道     | 25.6    | 16.9   |
| 14101      | 新篠津   | 北海道     | 25.7    | 17.1   |
| 14116      | 山口     | 北海道     | 26.3    | 17.5   |
| 14121      | 石狩     | 北海道     | 25.5    | 17.4   |
| 14136      | 江別     | 北海道     | 25.8    | 17.1   |
| 14163      | 札幌     | 北海道     | 26.4    | 19.1   |
