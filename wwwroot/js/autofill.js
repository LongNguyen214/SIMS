window.getInputValues = function (ids) {
    return ids.map(function (id) {
        try {
            var el = document.getElementById(id);
            if (el) {
                // dispatch input event to ensure Blazor bindings pick up autofilled values
                try {
                    var event = new Event('input', { bubbles: true });
                    el.dispatchEvent(event);
                } catch (e) {
                    // ignore
                }
                return el.value || '';
            }
            return '';
        } catch (e) {
            return '';
        }
    });
};
