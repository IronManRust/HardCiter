$(document).ready(function () {
    const agents = ["Clippy", "F1", "Genie", "Genius", "Links", "Merlin", "Rocky", "Rover"]; // "Bonzi", "Peedy"
    clippy.load(agents[Math.floor(Math.random() * agents.length)], function (agent) {
        console.log("Using " + agent.path.replace("agents/", "") + " as the documentation assistant.");
        agent.show();
        agent.moveTo(25, 150);
        setTimeout(function () {
            agent.speak("Welcome to the HardCiter service.");
            setTimeout(function () {
                agent.speak("To get started, click one of the links below.");
            }, 3000);
        }, 3000);
    });
});