window.showAlert = function (message) {
    alert(message);
}

window.callDotNetInstanceMethod = function (dotNetObjectReference) {
    dotNetObjectReference.invokeMethodAsync("SetWindowSize",
        {
            width: window.innerWidth,
            height: window.innerHeight,
        });
}

window.registerResizeHandler = function (dotNetObjectReference) {
    function resizeHandler() {
        dotNetObjectReference.invokeMethodAsync("SetWindowSize",
            {
                width: window.innerWidth,
                height: window.innerHeight,
            });
    };

    resizeHandler();

    window.addEventListener("resize", resizeHandler);
};