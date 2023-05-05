package filipaivankovic.lucijanpavic.practicalfilipa.data.model


import com.google.gson.annotations.SerializedName

data class Student(
    @SerializedName("students")
    val students: List<StudentX>
)