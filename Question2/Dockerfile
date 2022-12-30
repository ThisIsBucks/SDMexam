FROM node
WORKDIR /app
COPy package.json /app
RUN npm install
COPY  . /app 
CMD node server.js
EXPOSE 8080
//How to write Dockerfile for node?      