class BankAccount {
  static int _INCREMENTING_ID = 0;

  late double _balance;
  late int _id;

  BankAccount({double balance = 0}) {
    _balance = balance;
    _id = _INCREMENTING_ID++;
  }

  void deposit(double amount) {
    _balance += amount;
  }

  double get balance {
    return _balance;
  }

  int get id {
    return _id;
  }

  @override
  String toString() {
    return 'Account with \$$_balance';
  }
}

class Bank {
  List<BankAccount> _accounts;

  Bank() : _accounts = [];

  void addAccount(BankAccount account) {
    _accounts.add(account);
  }

  // nullable
  BankAccount? getAccount(int id) {
    for (int i = 0; i < _accounts.length; i++) {
      var account = _accounts[i];
      if (account.id == id) return account;
    }
    return null;
  }

  @override
  String toString() {
    // brackets sometimes are needed though
    return 'Bank with ${_accounts.length} accounts';
  }
}

void main() {
  var bank = Bank();
  bank.addAccount(new BankAccount());
  bank.addAccount(new BankAccount(balance: 15.8)); // neato
  bank.addAccount(new BankAccount(balance: 14017.62));

  var myAccount = new BankAccount(balance: 144.07);
  bank.addAccount(myAccount);

  print(bank.getAccount(myAccount.id));
}
