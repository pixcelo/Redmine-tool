# 公式イメージ, 安定版, 軽量なalpine版を利用
FROM node:16.14.2-alpine

WORKDIR /app

# Install package
COPY ./app/package.json ./app/yarn.lock ./
RUN yarn install

# Copy All files
COPY ./app .

# Start local server
ENTRYPOINT [ "yarn", "dev" ]
