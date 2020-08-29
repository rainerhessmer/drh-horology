const StatusCode = {
  UNKNOWN: 0,
  OK: 1,
  Error: 2,
};

class Status {
  static OK = new Status(StatusCode.OK);

  static createError(message) {
    return new Status(StatusCode.Error, message);
  }

  constructor(statusCode, message = "") {
    this.statusCode = statusCode;
    this.message = message;
  }

  ok() {
    return this.statusCode == StatusCode.OK;
  }
}

export { StatusCode, Status };