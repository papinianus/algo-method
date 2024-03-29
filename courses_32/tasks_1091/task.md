## 問題文

私たちが普段使っているグレゴリオ暦には、季節と暦のずれを補正するために平年より 1 日多い**うるう年**が存在します。

うるう年は次の規則に従って定められています：

- 西暦年が 4 の倍数の年は (原則) うるう年である
- ただし、西暦年が 100 の倍数の年は (原則) うるう年でない
- ただし、西暦年が 400 の倍数の年は必ずうるう年である

例えば、 2020 年は 1. のみを満たすのでうるう年です。

西暦 N 年はうるう年でしょうか。

## 入力

入力は次の形式で与えられます。

```text
N
```

また、入力される値は次の制約を満たします。

- N は 1583 以上 2100 以下の整数

## 出力

答えを出力してください。 西暦 N 年がうるう年ならば `Yes` を、そうでないならば `No` を出力してください。

## 入出力例

### 入力例 1

```text
2020
```

### 出力例 2

```text
Yes
```

問題文でも述べたとおり、 2020 年はうるう年です。

### 入力例 2

```text
1900
```

### 出力例 2

```text
No
```

1900 は 4 の倍数ですが 100 の倍数でもあるため、規則 2. が適用されます。 そのため、西暦 1900 年はうるう年ではありません。

### 入力例 3

```text
1603
```

### 出力例 3

```text
No
```
