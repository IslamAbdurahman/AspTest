window.addEventListener("load", () => {
    const key = "swagger_access_token";

    // Eski tokenni yuklash
    const savedAuth = window.localStorage.getItem(key);
    if (savedAuth) {
        ui.preauthorizeApiKey("Bearer", savedAuth);
    }

    // Yangi tokenni saqlash
    const origAuthorize = ui.authActions.authorize;
    ui.authActions.authorize = (auth) => {
        const token = auth?.Bearer?.value;
        if (token) {
            window.localStorage.setItem(key, token);
        }
        return origAuthorize(auth);
    };
});
