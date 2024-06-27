const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin')

const path = require('path');

module.exports = {
  entry: './modules/header/header.js", "./modules/body/body.js", "./modules/footer/footer.js',
  mode: 'development',
  output: {
    filename: '[name].bundle.js',
    path: path.resolve(__dirname, 'public'),
  },
  devtool: 'inline-source-map',
  devServer: {
    static: {
      directory: path.join(__dirname, './public'),
    },
    compress: true,
    port: 8564,
  },
  splitChunks: {
    chunks: 'all',
  },
  rules: [
    {
      test: /\.css$/i,
      use: ["style-loader", "css-loader"],
    },
    {
        test: /\.(png|jpg|svg|jpeg)$/i,  
        use: ['file-loader',{
            loader: 'image-webpack-loader',
        }]
    }
  ],
};