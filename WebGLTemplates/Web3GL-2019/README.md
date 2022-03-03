# Unity ^2020.1.0 Web3GL Template

## Methods in Browser

Dispay login modal:

```javascript
window.web3gl.connect();
```

Get Network:

```javascript
window.web3gl.networkId;
```

Get Connected Address:

```javascript
window.web3gl.connectAccount;
```

To Send Transaction:

```javascript
const to = "";
const value = "12300000000000000";
const gasLimit = "21000"; // gas limit
const gasPrice = "33333333333";
window.web3gl.sendTransaction(to, value, gasLimit, gasPrice);
```

To Interact with Contract:

```javascript
const method = "increment";
const abi = `[ { "inputs": [], "name": "increment", "outputs": [], "stateMutability": "nonpayable", "type": "function" }, { "inputs": [], "name": "x", "outputs": [ { "internalType": "uint256", "name": "", "type": "uint256" } ], "stateMutability": "view", "type": "function" } ]`;
const contract = "0xB6B8bB1e16A6F73f7078108538979336B9B7341C";
const args = "[]";
const value = "0";
const gasLimit = "222222"; // gas limit
const gasPrice = "333333333333";
window.web3gl.sendContract(method, abi, contract, args, value, gasLimit, gasPrice);
```

## Enable Torus

In `web3/index.js`

Uncomment

```javascript
document.body.appendChild(Object.assign(document.createElement("script"), { type: "text/javascript", src: "https://unpkg.com/@toruslabs/torus-embed" }));
```

```javascript
  const providerOptions = {
    torus: {
      package: Torus,
    }
  };
```

## Enable WalletConnect

In `web3/index.js`

Uncomment

```javascript
document.body.appendChild(Object.assign(document.createElement("script"), { type: "text/javascript", src: "https://unpkg.com/@walletconnect/web3-provider@1.2.1/dist/umd/index.min.js" }));
```

```javascript
  const providerOptions = {
    walletconnect: {
      package: window.WalletConnectProvider.default,
      options: {
        infuraId: "00000000000000000000000000000000",
      },
    }
  };
```

Replace `infuraId: "00000000000000000000000000000000"`
