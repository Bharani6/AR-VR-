
const WebSocket = require('ws');
const wss = new WebSocket.Server({ port: 8080 });

wss.on('connection', ws => {
   console.log('Client connected');
   
   setInterval(() => {
       // Simulate sending real-time data (e.g., speed, location)
       const data = JSON.stringify({
           speed: Math.random() * 100,
           ecoScore: Math.random() * 100
       });
       ws.send(data);
   }, 1000); // Send data every second
});
