const HtmlWebpackPlugin = require('html-webpack-plugin'); // Require  html-webpack-plugin plugin
const glob = require("glob");


module.exports = {
  entry:glob.sync("./src/*.js"), // webpack entry point. Module to start building dependency graph
  output: {
    path: __dirname + '/public/dist', // Folder to store generated bundle
    filename: 'bundle.min.js',  // Name of generated bundle after build
    publicPath: '/' // public URL of the output directory when referenced in a browser
  },
  module: {  // where we defined file patterns and their loaders
      rules: [ 
      ]
  },
  plugins: [  // Array of plugins to apply to build chunk
      new HtmlWebpackPlugin({
          template: __dirname + "/public/index.html",
          inject: 'body'
      })
  ],
  devServer: {  // configuration for webpack-dev-server
      contentBase: './public',  //source of static assets
      port: 7700, // port to run dev-server
  } 
};