## 問題文

カメのアルルは街のゲームセンターでゲームをプレーすることが好きです。 ある日ゲームセンターで、腕前を証明するゲームランクを取得していないにもかかわらず、とても上手なプレイヤーを見かけました。

その人のプレイヤーネームが RURU で終わることは覚えていたのですが、プレイヤーネーム全体やユーザ ID は忘れてしまいました。

---

いま、このゲームのユーザデータが格納された users テーブルのみからなるデータベースが与えられます。

アルルの記憶に合致するユーザを検索して、そのすべての情報を表示するクエリを作成してください。

ただしユーザがデータを公開していない (flg_data_public = FALSE(0) ) ユーザは検索することができないものとします。

## テーブル定義

| 物理名          | 型         | 必須? | 初期値 | 主キー? | 備考                                   |
| :-------------- | :--------- | :---- | :----- | :------ | :------------------------------------- |
| user_id         | INT        | YES   | NULL   | YES     | id 一意制約                            |
| name            | varchar(6) | NO    | NULL   | NO      | ユーザネーム                           |
| rank            | INT        | NO    | NULL   | NO      | ゲームランク NULL の場合もある         |
| flg_data_public | boolean    | NO    | NULL   | NO      | データ公開フラグ TRUE の場合のみ検索可 |

## データ例

| user_id  | name    | rank | flg_data_public |
| :------- | :------ | :--- | :-------------- |
| 435578   | U.RURU  | 10   | 0               |
| 872248   | ERARA   | null | 1               |
| 1540956  | U.RIRI  | 7    | 1               |
| 3356886  | A0RARA  | 9    | 0               |
| 3561597  | A0RORO  | 8    | 0               |
| 3999315  | A.RIRI  | 4    | 1               |
| 4265799  | A0RIRI  | 2    | 1               |
| 4308421  | O.RARA  | null | 1               |
| 5831819  | E.RIRI  | null | 1               |
| 6150444  | E!RURU  | 5    | 0               |
| 6323852  | U\*RARA | 5    | 1               |
| 7507864  | O\*RARA | null | 1               |
| 8526544  | U0RERE  | 6    | 1               |
| 8883684  | ORERE   | 11   | 0               |
| 9335534  | E-RURU  | 11   | 0               |
| 9583482  | I!RIRI  | null | 0               |
| 10576383 | E0RORO  | null | 1               |
| 10709497 | I0RARA  | 8    | 1               |
| 11668732 | A#RERE  | null | 1               |
| 12201654 | URARA   | 8    | 1               |
| 12448136 | E.RERE  | 1    | 0               |
| 12575562 | A-RIRI  | 11   | 1               |
| 12981052 | E!RERE  | 4    | 1               |
| 13556182 | I-RARA  | null | 1               |
| 13718431 | E0RERE  | 9    | 0               |
| 13756669 | A0RERE  | 11   | 1               |
| 14282218 | ARURUT  | null | 1               |
| 14716857 | U0RARA  | null | 1               |
| 14942603 | A\*RARA | 6    | 1               |
| 14972279 | U!RORO  | 11   | 1               |
| 15374874 | U#RIRI  | 6    | 1               |
| 16753883 | ERORO   | 9    | 1               |
| 18566572 | O-RURU  | 8    | 1               |
| 18728463 | ARERE   | 8    | 0               |
| 18740864 | O#RIRI  | null | 1               |
| 19175900 | O-RIRI  | 4    | 1               |
| 20514014 | U.RARA  | 7    | 1               |
| 20868105 | E#RARA  | 4    | 1               |
| 21227574 | U\*RURU | 2    | 1               |
| 21429110 | E\*RARA | 4    | 0               |
| 21472420 | U!RARA  | 9    | 1               |
| 21831063 | I.RERE  | 2    | 1               |
| 21931511 | I!RORO  | 1    | 1               |
| 22969840 | I\*RORO | 11   | 1               |
| 23978249 | ARURU.  | null | 1               |
| 25808537 | E0RURU  | null | 1               |
| 26687537 | A-RORO  | 7    | 1               |
| 28119557 | I#RERE  | 3    | 0               |
| 28317637 | O\*RERE | null | 0               |
| 28538251 | O!RERE  | 8    | 1               |
