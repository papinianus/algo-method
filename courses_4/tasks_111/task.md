## 問題文

L m のひもから、1 本の長さが A m のひもを切り取っていきます。

何本のひもを切り取ることができますか。ただし、あまったひもは捨てるものとします。

## 入力

入力データは次の形式で与えられます。

```text
L A
```

また、入力される値は次の制約を満たします。

- L,A は 1 以上 1000 以下の整数

## 出力

答えを出力してください。

## 入出力例

### 入力例 1

```text
13 3
```

### 出力例 1

```text
4
```

3 m のひもを 4 本切り取って、1 m あまります (3×4+1=13 m です)。

### 入力例 2

```text
15 5
```

### 出力例 2

```text
3
```

あまることなく、5 m のひもが 3 本切り取れます。

### 入力例 3

```text
3 100
```

### 出力例 3

```text
0
```

もとのひもが短すぎて、1 本も切り取れないこともあります。