Environment with Docker & Express & TypeScript & ts-node-dev

## Start container
```
docker-compose up -d --build
```

## Install required packages
```
# Excute running container
docker-compose exec express sh

# yarn initialization
yarn init

# add packages
yarn add express
yarn add --dev @types/express @types/node typescript ts-node-dev
```

## Initialization TypeScipt Setting
```
yarn run tsc --init
```

## Reference
https://qiita.com/Yuki-TU/items/14028be486306a0b41c4
https://qiita.com/yoskeoka/items/01c52c069123e0298660