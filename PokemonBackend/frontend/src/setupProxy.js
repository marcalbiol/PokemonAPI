const { createProxyMiddleware } = require('http-proxy-middleware');

const context = [
    "/weatherforecast",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: 'https://localhost:7001',
        secure: false
    });

    app.use(appProxy);
    app.listen(7001, () => {
        console.log("test");
    })
};
