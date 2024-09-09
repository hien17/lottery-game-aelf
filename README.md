# aelf Lottery Game Smart Contract

This guide will walk you through the steps to deploy a lottery game smart contract on the aelf testnet, acquire testnet ELF tokens, and interact with your deployed contract.</br>
</br>
This smart contract implements a lottery game where the outcome is determined by a random number obtained from the blockchain's block height. The key mechanism of this contract involves checking whether the random number is an even number to declare a winner.
## Prerequisites

- Ensure you have the aelf CLI tools installed.
- Have a wallet address and password ready.

## Steps

### 1. Create a wallet

Run this command to create an aelf wallet:

```shell
aelf-command create
```

### 2. Export Wallet Address and Password

Then export your wallet address and password as environment variables:

```shell
export WALLET_ADDRESS=your_wallet_address_here
export WALLET_PASSWORD=your_password_here
```
```shell
E.g.
export WALLET_ADDRESS=renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi
```

### 3. Acquire Testnet ELF Tokens

To deploy smart contracts or execute on-chain transactions on aelf, you'll require testnet ELF tokens. Use the following command to get testnet ELF tokens:

```shell
curl -X POST "https://faucet.aelf.dev/api/claim?walletAddress=$WALLET_ADDRESS" -H "accept: application/json" -d ""
```

To check your ELF balance, use the following command:

```shell
aelf-command call ASh2Wt7nSEmYqnGxPPzp4pnVDU4uhj1XW9Se5VeZcX2UDdyjx -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io GetBalance
```
```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <symbol>: ELF
? Enter the required param <owner>: renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi
The params you entered is:
{
  "symbol": "ELF",
  "owner": "renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi"
}
✔ Calling method successfully!
AElf [Info]: 
Result:
{
  "symbol": "ELF",
  "owner": "renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi",
  "balance": "20000000000"
} 
✔ Succeed!
```
Or you can check from the website, the account will be created on Mainchain AELF within aelf Testnet
```shell
https://testnet.aelfscan.io/AELF/address/ELF_renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi_AELF
```
### 4. Prepare the Smart Contract

Ensure your smart contract is compiled and ready for deployment. Set the path to your contract:

```shell
export CONTRACT_PATH=$(find ~+ . -path "*patched*" | head -n 1)
```

### 5. Deploy the Smart Contract

Use the following command to deploy your smart contract:

```shell
aelf-deploy -a $WALLET_ADDRESS -p $WALLET_PASSWORD -c $CONTRACT_PATH -e https://tdvw-test-node.aelf.io/
```
```shell
Start to deploy contract: /home/hien/aelfContracts/lottery-game/src/bin/Debug/net6.0/LotteryGame.dll.patched
Using account: renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi

Deploying contract without audit.
Added Genesis Contract address to whitelist          
successfully.whitelist ━━━━━━━━━━━━━━━━━━━━━━━━━━━━ ⢿
                                                     
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 02s: 067ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 03s: 528ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 04s: 934ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 06s: 343ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 07s: 823ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 09s: 264ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 10s: 661ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 12s: 110ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 13s: 568ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 15s: 124ms
[Processing]:                                        
ProposalId=fa4993b8ae22eff8db71215f0b0f49a0b08c26fee3059c5183b283c8000c301d, ToBeReleased: False, using   
time: 16s: 416ms
Author:                                              
"renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi" ⣾
Code hash:                                           
3bb53881d6b48db320248fb0f715b390be577db7264cf2f74852c
47ed534e261                                          
Address:                                             
"TnV4YTcKGsK58P4BAUGsiMoJq39t68WtQYiRbAcLFtE61V9td" ⣾
Version: 1                                           
ContractVersion: 1.0.0.0
Height: 137619281
Deploy Contract Info: { "serialNumber": "2149",      
"author": contract ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ ⡿
"renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi", 
"codeHash": 
"3bb53881d6b48db320248fb0f715b390be577db7264cf2f74852
c47ed534e261", "version": 1, "contractVersion": 
"1.0.0.0", "isUserContract": true, "deployer": 
"renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi" }
Contract deployed. 
```

If the deployment is successful, you'll receive a contract address. Save this address for future interactions:

```shell
export CONTRACT_ADDRESS="your_contract_address_here"
```
```shell
E.g.
export CONTRACT_ADDRESS="TnV4YTcKGsK58P4BAUGsiMoJq39t68WtQYiRbAcLFtE61V9td"
```
If you re-deploy same contract, the deployment will be failed

```shell
Start to deploy contract: /home/hien/aelfContracts/lottery-game/src/bin/Debug/net6.0/LotteryGame.dll.patched
Using account: renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi

Deploying contract without audit.
Added Genesis Contract address to whitelist successfully.        
                                                                 
Deployment failed: AElf.Sdk.CSharp.AssertionException: contract code has already been deployed before.
Will close this deployment tool.━━━━━━━━━━━━━━━━━━━━━━━━━━━ ⣾    
                                                                 
Deploying contract ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ ⣾    
                                                                 
```
You can find the contract here, it'll be deployed in sidechain tDVW within aelf Testnet
```shell
https://testnet.aelfscan.io/tDVW/address/ELF_TnV4YTcKGsK58P4BAUGsiMoJq39t68WtQYiRbAcLFtE61V9td_tDVW?tab=contract
```

### 6. Interact with the Deployed Contract

Now that your contract is deployed, you can interact with it using the aelf-command CLI.

#### Approving Smart Contract Spending

Note: ASh2Wt7nSEmYqnGxPPzp4pnVDU4uhj1XW9Se5VeZcX2UDdyjx is the contract address of Multitoken Contract on aelf Testnet Sidechain (tDVW).

```shell
aelf-command send ASh2Wt7nSEmYqnGxPPzp4pnVDU4uhj1XW9Se5VeZcX2UDdyjx -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io Approve
```
```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <spender>: 
TnV4YTcKGsK58P4BAUGsiMoJq39t68WtQYiRbAcLFtE61V9td
? Enter the required param <symbol>: ELF
? Enter the required param <amount>: 9000000000
The params you entered is:
{
  "spender": "TnV4YTcKGsK58P4BAUGsiMoJq39t68WtQYiRbAcLFtE61V9td",
  "symbol": "ELF",
  "amount": 9000000000
}
✔ Succeed!
AElf [Info]: 
Result:
{
  "TransactionId": "7f0702cf9abbd0efa6fdc9ee51e9cda8a0fef972c638c87baef8eb1e4f434ebe"
} 
✔ Succeed!
```

```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <value>: haha
The params you entered is:
{
  "value": "haha"
}
✔ Succeed!
AElf [Info]: 
Result:
{
  "TransactionId": "369dddacfe3dcb61354545dcf097fd9b278eee2490dc6b506be26482c2a22115"
} 
✔ Succeed!
```

#### Initializing Lottery Game Contract

```shell
aelf-command send $CONTRACT_ADDRESS -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io Initialize
```
```shell
✔ Fetching contract successfully!
✔ Succeed!
AElf [Info]: 
Result:
{
  "TransactionId": "639a6c29d4acf7af64e8de4634663cc3195b4c021472896146db2241b21d57bd"
} 
✔ Succeed!
```
#### Depositing funds into the Lottery Game Contract
```shell
aelf-command send $CONTRACT_ADDRESS -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io Deposit
```
```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <value>: 20000
The params you entered is:
{
  "value": 20000
}
✔ Succeed!
AElf [Info]: 
Result:
{
  "TransactionId": "e8714f5b82f36a30ac608c03b01b31df552df8213aa7aaf41caa43cdcb50e1c9"
} 
✔ Succeed!
```
#### Playing the Lottery Game
```shell
aelf-command send $CONTRACT_ADDRESS -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io Play
```
```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <value>: ELF
The params you entered is:
{
  "value": "ELF"
}
✔ Succeed!
AElf [Info]: 
Result:
{
  "TransactionId": "b098cbc2d10fcb1213f3efbcf5ee22783490bbf05b9d714778e44a01c45f619b"
} 
✔ Succeed!
```
```shell
aelf-command call ASh2Wt7nSEmYqnGxPPzp4pnVDU4uhj1XW9Se5VeZcX2UDdyjx -a $WALLET_ADDRESS -p $WALLET_PASSWORD -e https://tdvw-test-node.aelf.io GetBalance
```
```shell
✔ Fetching contract successfully!

If you need to pass file contents as a parameter, you can enter the relative or absolute path of the file

Enter the params one by one, type `Enter` to skip optional param:
? Enter the required param <symbol>: ELF
? Enter the required param <owner>: 
renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi
The params you entered is:
{
  "symbol": "ELF",
  "owner": "renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi"
}
✔ Calling method successfully!
AElf [Info]: 
Result:
{
  "symbol": "ELF",
  "owner": "renvwy4neaUgk2ce1qztSSbEjjt1zupQf1UzuR5jbQucUjXfi",
  "balance": "19705432500"
} 
✔ Succeed!
```
### 7. Verify Contract Deployment

You can verify your contract deployment by checking the transaction status or by calling a method on your contract.

### 8. Best Practices

- Always keep your wallet private key and password secure.
- Test your smart contract thoroughly on the testnet before deploying to mainnet.
- Monitor your contract's performance and interactions regularly.

### 9. Troubleshooting

If you encounter issues during deployment or interaction:
- Double-check your wallet address and password.
- Ensure you have sufficient testnet ELF tokens.
- Verify that your contract code compiles without errors.
- Check the aelf network status and ensure you're connected to the correct endpoint.

