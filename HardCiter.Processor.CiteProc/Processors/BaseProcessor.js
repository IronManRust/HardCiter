module.exports = function (callback, library) {

    eval(library); // We can't use require() syntax since the CiteProc library isn't being read off disk.

    const response = {
        "name": "Citation Style Language (CSL)",
        "version": "v" + CSL.PROCESSOR_VERSION,
        "runtime": "Node.js,Version=" + process.version
    };

    callback(null, JSON.stringify(response));

};