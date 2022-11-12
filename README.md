# algo-method

## urls

- [algo-method](https://algo-method.com/tasks)
- courses => `https://algo-method.com/courses/${id}`
- task => `https://algo-method.com/tasks/${id}`
- submissions => `https://algo-method.com/submissions/${id}`

## langs

- cshapr は mono

  - csharp 6.0 未満
  - MinBy/MaxBy がつかえない
  - Zip では Func が必須(python 式の zip であっても)
  - Dictionary の TryGet で out 引数で宣言できない

- typescript

```sh
pnpm init
pnpm i -D @types/node typescript@next tsc-watch
npx tsc --init
```
