module.exports = function (callback, library, locale, definition, format, data) {

    eval(library); // We can't use require() syntax since the CiteProc library isn't being read off disk.

    const retriever = {
        retrieveLocale: function () {
            return locale;
        },
        retrieveItem: function (id) {
            return data[id];
        }
    };

    const items = [];
    for (const item in data) {
        items.push(item);
    }

    const citeProc = new CSL.Engine(retriever, definition);
    citeProc.setOutputFormat(format);
    citeProc.updateItems(items);

    const results = citeProc.processCitationCluster({ "citationItems": [{ "id": "0" }] }, [], []);
    const response = {
        "metadata": results[0],
        "value": results[1]
    };

    callback(null, JSON.stringify(response));

};