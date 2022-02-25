param (
    [Parameter()]
    [string] $name
)

switch ($name) {
    "unity2019" {
        return "2019.4.34f1"
    }
    "unity2020" {
        return "2020.3.27f1"
    }
    "unity2021" {
        return "2021.2.10f1"
    }
    Default {
        throw "Unkown variable '$name'"
    }
}