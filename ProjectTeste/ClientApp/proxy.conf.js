const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:9646';

const PROXY_CONFIG = [
  {
    context: [
      "/api",
   ],
    proxyTimeout: 10000,
    target: "https://localhost:44365", 
    secure: false,
    "changeOrigin": false  // I tried with and without this. No luck
    //headers: {
    //  Connection: 'Keep-Alive'
    //}
  }
   
]

module.exports = PROXY_CONFIG;
